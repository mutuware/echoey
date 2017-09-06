# echoey

This app can allow you to mock out an API (i.e. a 3rd party server).
Could be used for integration testing or prototyping a UI against a mock API.

Setup:

curl -X POST \
  http://localhost:5000/_api/routes \
  -H 'content-type: application/json' \
  -d '{ "Url" : "/weather", "verb": "GET", "response": "{ '\''location'\'': '\''leith'\'', '\''condition'\'': '\''sunshine'\'' }" }'
  
Check setup:

curl -X GET http://localhost:5000/_api/routes 

 
Usage:

curl -X GET http://localhost:5000/weather 

Response:

{ 'location': 'leith', 'condition': 'sunshine' }


Note that currently all data is transient. So setup should be saved in a script to run each time the server is created.
