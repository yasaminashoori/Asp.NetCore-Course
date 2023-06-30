# Asp .Net Core Course
Hi everyone! welcome to the second semester of programming learning from the Ashkan Rahmani Course

Blogs:
 <a href="https://www.freecodecamp.org/news/statement-vs-expression-whats-the-difference-in-programming/#:~:text=Expressions%20are%20unique%20in%20meaning,of%20code%20is%20a%20statement.">Statement VS Expression</a>

# Notes of Course

- What is Backend?

Every app in the web has two parts front and back. 

the front is based on SPA today or SSA

they connect with API.

Web API is not a tool but a concept! that works with HTTP Protocol.

And when we say API, another concept comes too: Rest (Representational Estate Transfer) and say RestFul API.

RestFul:
1. URL Structure
2. Separation between client and server
3. Stateless(client state)
4. HTTP Verb (POST, PUT, GET, PATCH, DELETE)

What is HTTP Request? 
Hyper Text Transfer Protocol
From Client to Server => Request (URL, HTTP MEthod(verb), Header, Body, Data)
From Server to Client => Response (Status Code, Response Header, Data)

HTTP Verb: 
GET: Just read sth from DB and send it.

POST: Make an item in Db or Write it.

PUT: Update the Data.

PATCH: just a part of data (partial data).

DELETE: delete an item in DB.

Header: not the primary data and generics like IP, Location

Body: the request should contain some data such as the book's info that we want to update.

Data: Another Infos except for Body. such as images etc.


Response: 
Status code: 5 Category : 1xx, 2xx, 3xx, 4xx, 5xx.
1xx: informational response.
2xx: successful
3xx: Redirection
4xx: Client Error
5xx: server Error

200: ok
201: created- create the object in the server ( POst )
204: no content - normally, ok but nothing returns
301: Moved permanently 
302: moved temp
400: Bad request - client body error. the request has a problem. 
401: Unauthorized token or not working. (no access)
403: Forbidden - valid token or you don't have access in this level (location not allowed)
404: not found in server so client understands or a route has a problem and is not found
405: Method  not Allowed - when a method verb is wrong it should be POST but You send Get.
500: all errors in our server, and internal server errors. unhandled exception, or crashed! or bug. (dangerous)
503: Service unavailable. don't service
504: getaway time out, the process takes so much long related to the server.

















