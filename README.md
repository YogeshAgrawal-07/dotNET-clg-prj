_**🌐 Author    -    Yogesh Agrawal**_



_**🧩 MyLinks — Personal Link Aggregator:**_

   - A minimalist, responsive LinkTree-style web app built with ASP.NET Core Razor Pages, C#, and Tailwind CSS. Designed as a personal hub for Yogesh Agrawal’s online profiles.



_**🚀 Features:**_

   ⚙️ C# Backend — Links and profile details managed via IndexModel.cs.
   
   💡 Razor Pages Frontend — Dynamic content rendered using C# logic in .cshtml.
   
   🎨 Modern UI — Dark theme, smooth animations, and Tailwind-powered design.  
   
   🖼️ Profile Image Support — Drop your image in wwwroot/images/.   
   
   📱 Fully Responsive — Optimized for mobile and desktop.



_**🧰 Tech Stack:**_

                 **Technology**                           **Purpose**                 
                   .NET 8.0+	                       Backend framework
           ASP.NET Core Razor Pages	                    Page rendering
                  Tailwind CSS                        Styling and layout
                       C#                         	       App logic



_**🛠️ Installation & Setup**_

**Prerequisites**

 ➢ .NET 8.0 SDK+
 
 ➢ Visual Studio / VS Code



_**Steps**_

    1. Clone the repo
    
      git clone https://github.com/YogeshAgrawal-07/MyLinks.git
      cd MyLinks

    2. Restore dependencies
      dotnet restore

    3. Run the app
      dotnet run

    Then visit the URL printed in console (e.g. https://localhost:7297/).



_**📁 Project Structure**_

    MyLinks/
    ├── .vs/
    ├── bin/
    ├── obj/
    ├── Pages/
    │   ├── Shared/
    │   │   ├── _Layout.cshtml
    │   │   ├── _Layout.cshtml.css
    │   │   ├── _ValidationScriptsPartial.cshtml
    │   │   ├── _ViewImports.cshtml
    │   │   └── _ViewStart.cshtml
    │   ├── Error.cshtml
    │   ├── Error.cshtml.cs
    │   ├── Index.cshtml
    │   ├── Index.cshtml.cs
    │   ├── Privacy.cshtml
    │   └── Privacy.cshtml.cs
    ├── Properties/
    │   └── launchSettings.json
    ├── wwwroot/
    │   └── images/
    ├── appsettings.json
    ├── appsettings.Development.json
    ├── Program.cs
    ├── MyLinks.csproj
    ├── MyLinks.csproj.user
    ├── MyLinks.sln



_**🧪 Local Customization**_

   ● Update your name and links in Index.cshtml.cs (List<LinkItem>).

   ● Replace the profile image in wwwroot/images/.
   
   ● Adjust theme colors via Tailwind utility classes in Index.cshtml.



📸 Preview

<img width="1920" height="1032" alt="image" src="https://github.com/user-attachments/assets/07e16e29-81d2-40df-9c46-924d63c04188" />
