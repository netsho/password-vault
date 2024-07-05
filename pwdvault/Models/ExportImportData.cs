/*
Netsho - Defines password data in a form suitable for export / import. 
Copyright (C) 2023-2024 Netsho

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program. If not, see <https://www.gnu.org/licenses/>.
*/
namespace pwdvault.Models
{
    public class ExportImportData(string appCategory, string appName, string userName, string password)
    {
        public string AppCategory { get; set; } = appCategory;
        public string AppName { get; set; } = appName;
        public string UserName { get; set; } = userName;
        public string Password { get; set; } = password;
    }
}
