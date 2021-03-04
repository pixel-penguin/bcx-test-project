# BCX Project by Gerrit Vermeulen

## Database

### Migrations
With the database, I normally use code-first (however in Laravel, we mainly just called it migrations). It's much cleaner and especially working on bigger projects, it makes live easier

### Seeding
I also created seeds that will populate the database with the relevant data in order to proceed.

## Authentication

### Identity
I added Authentication to the project that uses the standard "Identity". So if you get to the admin that requires authentication, just register a new account and proceed to log in.
Obviously in a live project it should be that easy, but since this is a test project, I didn't add more functionality to either ban someone from registering or giving a newly registerd person a non-admin role.

## Database
### Queries
I tried not to use queries, and strickly Entity's Framework
### Field validations and limitations
I did notice you can do A LOT more effort on the limitations, size, e.g. on the columns of the DB. And the best part is that if you use bind field with Models in Razor, it does the majortiy of the validation on the client-side for you.
However, I did not use this feature a lot. But this is definetaly a great feature.

## HTML Fields
### Naming Conventions
With Laravel the nameing conventions is completely different, and I kep finding myself typing in camelCase. I would assume it's better practice to have the NameFields on the input should be the same as on the Model.
