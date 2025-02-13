<!--
 Copyright (C) 2025 Javier Castorena
 
 This file is part of EmporioSystem.
 
 EmporioSystem is free software: you can redistribute it and/or modify
 it under the terms of the GNU General Public License as published by
 the Free Software Foundation, either version 3 of the License, or
 (at your option) any later version.
 
 EmporioSystem is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.
 
 You should have received a copy of the GNU General Public License
 along with EmporioSystem.  If not, see <https://www.gnu.org/licenses/>.
-->

http://localhost:5091/api/Item/GetAllItems

Install packages

 Microsoft.EntityFrameworkCore.tools 
    :Api
 Npgsql.EntityFrameworkCore.PostgreSQL
    :Api,Data,User
Microsoft.AspNetCore.Identity.EntityFrameworkCore
    :User
Microsfot.EntityFrameworkCore.Design


Add migrations 
 Migration
 dotnet ef migrations add UserMigration --project ..\AolDeviceConfig.User\  --context EmployeeContext
 dotnet ef migrations add DataMigration --project ..\AolDeviceConfig.Data\ --context ConfigContext
 dotnet ef database update --context EmployeeContext --project AolDeviceConfig.Api
 dotnet ef database update --context ConfigContext --project AolDeviceConfig.Api
