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
  
   
