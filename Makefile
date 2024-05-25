COMMAND = docker compose -f ./docker-compose.yml --env-file ./.env

up:
	$(COMMAND) up -d

start:
	$(COMMAND) start

stop:
	$(COMMAND) stop

restart:
	$(COMMAND) stop
	$(COMMAND) start