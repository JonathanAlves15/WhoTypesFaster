import socket
import threading
import random
import select

# Lista de textos
TEXTS = [
    "O tempo perguntou pro tempo quanto tempo o tempo tem. O tempo respondeu pro tempo que o tempo tem tanto tempo quanto tempo o tempo tem.",
    "A vaca malhada foi molhada por uma chuva molhada malvada.",
    "O rato roeu a roupa do rei de Roma."
]

# Configuração do servidor
HOST = "0.0.0.0"
PORT = 5000
server = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server.bind((HOST, PORT))
server.listen()

print(f"Servidor iniciado em {HOST}:{PORT}")

players_queue = []
active_games = {}

def handle_client(client_socket, addr):
    print(f"Novo jogador conectado: {addr}")
    
    try:
        players_queue.append(client_socket)

        if len(players_queue) >= 2:
            start_game()
            return
        
        while True:
            # Usa select para verificar se o socket está ativo sem bloquear
            ready, _, _ = select.select([client_socket], [], [], 5)
            if ready:
                data = client_socket.recv(1024)
                if not data:
                    raise ConnectionResetError
        
    except (ConnectionResetError, ConnectionAbortedError, OSError):
        print(f"Jogador {addr} desconectado antes da partida.")
        if client_socket in players_queue:
            players_queue.remove(client_socket)
        client_socket.close()

def start_game():
    player1 = players_queue.pop(0)
    player2 = players_queue.pop(0)

    text = random.choice(TEXTS)
    game_id = f"game_{id(player1)}_{id(player2)}"
    active_games[game_id] = {"text": text, "players": {player1: "", player2: ""}}
    
    for player in [player1, player2]:
        player.send(f"START|{text}".encode())
    
    threading.Thread(target=game_loop, args=(game_id, player1, player2)).start()

def game_loop(game_id, player1, player2):
    print(f"Monitorando jogo {game_id}")

    while True:
        # Diferencia os players
        for player in [player1, player2]:
            other_player = player1 if player == player2 else player2

            # Verifica se o socket ainda está ativo antes de tentar receber dados
            ready, _, _ = select.select([player], [], [], 5)
            if ready:
                try:
                    data = player.recv(1024).decode()
                    if not data:
                        raise ConnectionResetError  # Cliente desconectado

                    if data.startswith("FINISH|"):
                        typed_text = data.split("|", 1)[1]
                        if typed_text == active_games[game_id]["text"]:
                            player.send("WIN".encode())
                            other_player.send("LOSE".encode())
                            del active_games[game_id]
                            return

                except (ConnectionResetError, ConnectionAbortedError, OSError):
                    print(f"Jogador desconectado durante a partida: {player}")
                    other_player.send("OPPONENT_DISCONNECTED".encode())
                    player.close()
                    del active_games[game_id]
                    return

while True:
    client_socket, addr = server.accept()
    threading.Thread(target=handle_client, args=(client_socket, addr)).start()