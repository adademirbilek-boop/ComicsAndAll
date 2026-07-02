> This project is currently under active development.

# ComicsAndAll
Comic tracking platform inspired by MyAnimeList, Letterboxd and Backloggd.

## Goals

- Track comic reading progress

- Contribute to comicbook rankings by giving them ratings

- Get reccomendations determined by your comicbook ratings

- Build a comicbook run database with community support

## Tech Stack

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- C#

## Current status

Early Development.

## Completed

- Database Schema created
- EF Core configured
- SQL Server database created
- Initial migration completed
- Added the initial placeholder data
- Implemented repository and use case structure for series and characters
- Built Series Index and Series Details pages
- Displayed related issues on the Series Details page
- Added ViewModels for details pages
- Added Character Index and Character Details pages
- Added placeholder images for missing cover/profile images
- Updated navigation links for Home, Series and Characters
- Added Publishers Index and Publishers Details pages
- Added Creators Index and Creators Details pages
- Implemented ASP.NET Identity authentication
- Implemented User Profile system
- Added automatic User Profile creation for newly registered users
- Created Profile page with ViewModel architecture
- Implemented Favorite Characters system
- Prevented duplicate favorite characters
- Added favorite character limit
- Added remove favorite functionality
- Protected profile actions with authorization
- Applied Use Case pattern for authentication-related business logic

## Development Log

### 2026-06-11

- Created project architecture
- Designed core entities
- Created first migration
- Connected SQL Server database

### 2026-06-15

  - Imported placeholder comic metadata into local SQL Server database
  - Cleaned the SQL seed files to match the current entity structure
  - Fixed SQL Server compatibility issues such as identity inerts, nullable fields and boolean values
  - Verified that the main database tables were populated correctly

### 2026-06-16

  - Added relationships between Series and Issues
  - Implemented Series Details logic
  - Displayed issue lists under each series
  - Added publisher names to series details
  - Created the necessary ViewModels for detail pages instead of passing entities directly into views
  - Improved Razor Views with placeholder coverimages and cleaner layouts

### 2026-06-17

 - Added Characters Index page
 - Added Characters Details page
 - Added placeholder images for Characters
 - Improved visual layout of Series and Characters pages

### 2026-06-18

- Added Publishers Index and Details page
- Added Creators Index and Details page

### 2026-06-19

- Implemented UserProfile entity and repository
- Added User Profile page
- Created ProfileViewModel
- Connected ASP.NET Identity users with UserProfile records
- Added automatic profile creation for new users

### 2026-06-20

- Implemented Favorite Characters system
- Added FavoriteCharacter entity and repository
- Added business rules through UseCases
- Prevented duplicate favorite entries
- Added maximum favorite character limit
- Displayed favorite characters on profile page
- Implemented remove favorite functionality

### 2026-06-21

- Added authentication-aware profile logic
- Restricted profile actions to authenticated users
- Prevented unauthorized favorite management
- Added conditional UI rendering based on authentication state
- Improved controller architecture by moving business logic into UseCases
