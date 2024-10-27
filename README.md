# InnoNum

A small web api written in C# which calculates
[perfect numbers](https://w.wiki/BaPy).
Also includes a basic Angular frontend for this api.

> **Note:** This repository was created for a small job
> interview exercise.  It probably isn't of much use
> beyond that.

## Building & Running

### Backend

The backend depends on a working
[.NET SDK](https://dotnet.microsoft.com).
It was developed and tested with **.NET 8**.

```sh
$ cd backend/InnoNum.Api
$ dotnet run
```

The `backend/` directory contains a solution file
that *should* work with Visual Studio.
I can't test this because I don't have access
to Visual Studio at the moment.

### Frontend

The frontend needs a working
[Angular](https://angular.dev)
install.  It was developed and tested with
**Angular v18**.

```sh
$ cd frontend/
$ npm start run
```

## Things left to do

* A CI config for GitHub.
* An optimized perfect number calculation algorithm.
* A prettier frontend.
* (Probably a few more things.)

