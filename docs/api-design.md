# API design

REST endpoints for the gaming club API. A path names the resource, the HTTP method names the action.

| Method | Path | Description | Success code | Error codes |
|---|---|---|---|---|
| GET | `/clients` | List all clients | 200 | |
| GET | `/clients/{id}` | Get one client | 200 | 404 if not found |
| POST | `/clients` | Register a new client | 201 | 400 if the data is invalid |
| PUT | `/clients/{id}` | Update a client | 200 or 204 | 400, 404 |
| DELETE | `/clients/{id}` | Delete a client | 204 | 404 |
| GET | `/clients/{id}/sessions` | List a client's gaming sessions | 200 | 404 if the client does not exist |
| POST | `/clients/{id}/sessions` | Start a new session for a client | 201 | 400, 404 |

## Status codes used

- **200 OK**: request succeeded.
- **201 Created**: a new resource was created.
- **204 No Content**: succeeded, nothing to return.
- **400 Bad Request**: the client sent invalid data.
- **404 Not Found**: the requested resource does not exist.
- **500 Internal Server Error**: a bug on the server side.
