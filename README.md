# BuyBuy-ASP-NET
C# ASP.NET, Code-first migrations, REST API

REST API:

MOVIES:

GET /api/movies/
GET /api/movies/{Id}
POST /api/movies/
- Body:
    {
        "name": "Shrek 1",
        "releaseDate": "1754-10-10T00:00:00",
        "numberInStock": 999,
        "genreId": 1
    }
    
PUT /api/movies/{Id}
- Body:
    {
        "name": "Shrek 1",
        "releaseDate": "1754-10-10T00:00:00",
        "numberInStock": 999,
        "genreId": 1
    }

DELETE /api/movies/{id}

CUSTOMERS:

GET /api/customers/
GET /api/customers/{Id}
POST /api/customers/
- Body:
    {
        "name": "John Smith",
        "isSubscribedToNewsletter": true,
        "birthdate": "2000-04-04T00:00:00",
        "membershipTypeId": 1
    }
    
PUT /api/customers/{Id}
- Body:
    {
        "name": "John Smith",
        "isSubscribedToNewsletter": true,
        "birthdate": "2000-04-04T00:00:00",
        "membershipTypeId": 1
    }

DELETE /api/customers/{id}
