import socket
import threading
import random
import select

# Lista de textos para o jogo
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
    players_queue.append(client_socket)
    
    # Inicia o jogo quando há dois jogadores na sala
    if len(players_queue) >= 2:
        start_game()

def start_game():
    player1 = players_queue.pop(0)
    player2 = players_queue.pop(0)

    # Escolhe um texto aleatório no vetor TEXTS
    text = random.choice(TEXTS)

    game_id = f"game_{id(player1)}_{id(player2)}"
    active_games[game_id] = {"text": text, "players": {player1: "", player2: ""}}
    
    # Avisa ao jogadores que o jogo começou
    for player in [player1, player2]:
        player.send(f"START|{text}".encode())
    
    threading.Thread(target=game_loop, args=(game_id, player1, player2)).start()

def game_loop(game_id, player1, player2):
    while True:
        ready, _, _ = select.select([player1, player2], [], [], 5)

        # Diferencia os players
        for player in ready:
            other_player = player1 if player == player2 else player2

            try:
                data = player.recv(1024).decode()
                if data.startswith("FINISH|"):
                    typed_text = data.split("|", 1)[1]
                    if typed_text == active_games[game_id]["text"]:
                        player.send("WIN".encode())
                        other_player.send("LOSE".encode())
                        del active_games[game_id]
                        return
            except:
                return

while True:
    client_socket, addr = server.accept()
    threading.Thread(target=handle_client, args=(client_socket, addr)).start()