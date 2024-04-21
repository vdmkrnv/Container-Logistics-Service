rem COMPOSE_HTTP_TIMEOUT=200
docker compose -p logic build 
docker compose -p logic up  -d --force-recreate
pause