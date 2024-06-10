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
namespace pwdvault.Modeles
{
    internal class ExportImportData
    {
        public string AppCategory { get; set; }
        public string AppName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ExportImportData(string appCategory, string appName, string userName, string password)
        {
            AppCategory = appCategory;
            AppName = appName;
            UserName = userName;
            Password = password;
        }
    }
}
