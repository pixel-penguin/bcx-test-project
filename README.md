# BCX Project by Gerrit Vermeulen

## Database

### Migrations
With the database, I normally use code-first (however in Laravel, we mainly just called it migrations). It's much cleaner and especially working on bigger projects, it makes live easier

### Seeding
I also created seeds that will populate the database with the relevant data in order to proceed.

## Authentication
I added Authentication to the project that uses the standard "Identity". So if you get to the admin that requires authentication, just register a new account and proceed to log in.
Obviously in a live project it should be that easy, but since this is a test project, I didn't add more functionality to either ban someone from registering or giving a newly registerd person a non-admin role.

