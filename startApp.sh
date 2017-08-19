docker build -t jaca-api . --no-cache
docker run -t -p 1234:5000 jaca-api

echo "CONTAINER UP MOTHERFUCKER!"