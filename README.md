# BCX Interview Project by Gerrit Vermeulen

## Database

### Migrations
With the database, I normally use code-first (however in Laravel, we mainly just called it migrations). It's much cleaner and especially working on bigger projects, it makes live easier

Not sure if it's done by itself or you have to enable it on your side as well:
```
enable-migrations
update-database
```

### Seeding
I also created seeds that will populate the database with the relevant data in order to proceed.

## Authentication

### Identity
I added Authentication to the project that uses the standard "Identity". So if you get to the admin that requires authentication, just register a new account and proceed to log in.
Obviously in a live project it shouldn't be that easy, but since this is a test project, I didn't add more functionality to either ban someone from registering or giving a newly registerd person a non-admin role.

## Database
### Queries
I tried not to use queries, and strickly Entity's Framework, except when seeded to the database;
### Field validations and limitations
I did notice you can do A LOT more effort on the limitations, size, e.g. on the columns of the DB. And the best part is that if you use bind field with Models in Razor, it does the majortiy of the validation on the client-side for you.
However, I did not use this feature a lot. But this is definetaly a great feature.

## HTML Fields
### Naming Conventions
With Laravel the nameing conventions is completely different, and I kept finding myself typing in camelCase. I would assume it's better practice to have the NameFields on the input fields should be the same as on the Model (Database Column Names), however I failed to follow these rules in the html input name fields.

## Deleting Questions
Once you click on a question to be deleted, there is no "Are you sure" prompts.

# CSS and Styling
## Questionair CSS
Normally I use Bootrap or Tailwindcss, however as the project asked to only have a single css file, I didn't include it. I did extract some of the styling from bootstrap and placed them inside my style.css. I tried my best to use a single small css file.
## Admin CSS
I added a second stylesheet called admin.css that will only be used on admin, since it also uses the style.css. Normally I would have admin use a seperate css files from the website itself.

## Overall Experience
If I would compare ASP.net MVC with a framework like Laravel, I would honestly say that C# really beats Laravel in the overall of the way the logic works, especially how Models and migrations connect with each other. Visual Studio does a great job help guiding you in the right direction. How the model relationshiop works is also truly amazing, but I have to admit, I find Laravel's Eloquent Model query handling a bit more powerful (but that could be since I'm more used to it).
