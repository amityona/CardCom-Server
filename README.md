To Run The Web Service use :
1) docker run -d --name postgres-container -e POSTGRES_USER=admin -e POSTGRES_PASSWORD=admin -e POSTGRES_DB=Persons -v /path/to/host/volume:/var/lib/postgresql/data -p 5432:5432 postgres:latest
2) dotnet ef migrations add InitialCreate
3) dotnet ef database update

Check out this video demonstration:

[![Video Demo](https://img.youtube.com/vi/CPKXnBkBqFo/0.jpg)](https://www.youtube.com/watch?v=CPKXnBkBqFo)

