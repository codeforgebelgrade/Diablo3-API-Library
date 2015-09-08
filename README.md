# Diablo3 API .NET Library
C# library that retrieves data from Blizzard Diablo 3 API. If you are making your own .NET Diablo 3 application, you can simply import this library and use it to fetch the data - basically, you can focus on your application and let the library take care of the API and the data. I made this for my own Diablo 3 application for Windows Phone - unfortunately, I am not sure if I am going to continue working on that app, but this might be helpful for someone else working on similar project.   

# How it works

IMPORTANT: If you are using this library, I will assume that you are already working on some Diablo 3 application, so you will need Mashery account (required by Blizzard in order to use their API). If you do not have Mashery account already, you can create it here: https://dev.battle.net/member/register. Also, keep in mind that your BattleTag have to be submitted with dash instead of "#" (for example, Something-1234, instead Something#1234). You may also need to restore NuGet packages when you checkout the project. More information about this can be found here: http://docs.nuget.org/consume/package-restore 

IMPORTANT: At the moment, library does not retrieve item info. This will be added soon. There are also some unhandled exceptions (when you send some dumb data to API), but I will fix that as soon as I set some time aside. 

1. Create Mashery account
2. Import the library in your project (see Diablo3APIDemo)
3. Call the corresponding method of DiabloService class to get the result. You can convert the result to JSON (as I did in the Demo project, or use it as-is in your project). 

If you think this is useful, or you have idea how to improve it, please feel free to contribute. If you play Diablo, I'm PainBringer#2214 - feel free to add me.  


