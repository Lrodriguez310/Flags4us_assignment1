Programmer name: Luis Rodriguez

Company name: Flags4us

Program purpose: To create a program to sell flags and show everyone the types of flags in stock and detail about each flag

Date created: 10/12/2022

Date last edited: 10/13/2022


I LEFT ASCII ART THROUGHOUT THE READ ME TO KEEP YOU ENTERTAINED. PLEASE ENJOY PROFESSOR :)


ASCII art is open for everyone to use I do not own and I did not create any of the art below this line____________
The art was taken from this site www.asciiart.eu


   (`'`'`'`')
    |      |
    |      |
   (|-()()-|)
    | (__) |    ------ Buy our flags, or ELSE!
    |  _   |
    |______|
   /._/\/\_.\                            .------.
  /  , /\    \                          ( ______ )
 ; / \\|| __  ;                         (________)
 |-|  './ \/|-|                         (  water )
 \ |   |    | /     Great delivery      (--------)
  '\___|____/`           .-""-.         ( ______ )
    |--LI--|           .'      \         \_    _/
    |  |   |          //  |-()()         __|__|__
    |  |   |         ; |  |  () |    ___/        \
    |  |   |         | `" `     |    |  |  ____  |
    |  |   |       ,_|   | |    |    |  | | || | |
    |  |   |       `-;   (_}    ;    |__| |____| |
    |  |   |          '.,   __.'      \/|        |
    |__|___|            / /|  |         |        |
..----'=||='----.      / / |  |         |        | 
`""""`"  "`""""`      (__) (__)         |________|



 We have the flags!
  |        
   \___     (_:..'"=
            ::/ o o\         
           ;'-'   (_)           
           '-._  ;-'   Lets Sell Some FLAGS!   /\/\
           .:;  ;                .         '- '   /_
          :.. ; ;,                \       _/,    "_<
         :.|..| ;:                 \__   '._____  _)
         :.|.'| ||                            _/ /
         :.|..| :'                           `;--:
         '.|..|:':       _               _ _ :|_\:
      .. _:|__| '.\.''..' ) ___________ ( )_):|_|:
:....::''::/  | : :|''| "/ /_=_=_=_=_=/ :_[__'_\3_)
 ''''      '-''-'-'.__)-'





  \/________________        
 /     _____________)
/     /     /   \ |         
\/\/\/     (O) (O)|           
  |           ------, 
  |  _       ______/ 
  | (_      /   \  \
  |        /  ___\_ \ ======= (I need stone flags)    
  |        \      / / 
__|_________\______/
\______________\./__\   
 /     .       | \  |
 \    /_\   .  |  \ |\     
 |`\       /_\ |   \| \
______________________________________________________________________________________________________________________________________________________________________________________________________
 9:30am - Project Start
         I began by setting up the mvc file so that I can do the project with no problems/ individual accounts 
 
 9:37am - I will begin by commenting out the  // "sslPort": 44367 under properties -> launchSettings.json 
          This will allow me to view the page with no issues

 10:00 am - linked project to github using git and add new repository: this will help back up my project

 10:20 am - added an About us page by making a .cshtml file and named it "AboutUS" @*
    
    For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
*@
@{
    ViewData["Title"] = "About Us";
}
<h1>@ViewData["Title"]</h1>


10:32 am - had trouble viewing the about us page so I added something to the HomeController.cs 
  public IActionResult AboutUs()
        {
            return View();
        }


10:40 am - went to layout.cshtml and put in a navigation for the about us page
<li class="nav-item">
                            <a class="nav-link text-dark" asp-area="" asp-controller="Home" asp-action="AboutUs">About us</a>
                        </li>

10:50 am - added text to the about us page talking about our company Flags 4 Us

11:28 am - about us page is full of text and I will be adding more to it later.


11:44 am - added a catalogue in the navigation bar and then hyperlinked the title of the index page to the catalogue.

11:49 am - I have also hyperlinked the title of the app to go into the catalogue page.


12:19 pm - added a flags.cs and put in: public int Id { get; set; }

        //   [Display(Name = "Product Name")]
        //   [StringLength(60, MinimumLength = 3)]
        //  [Required]
        public string ProductName { get; set; }


        //   [Display(Name = "Product Description ")]
        //   [Required]

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        //  [StringLength(30)]
        public string Size { get; set; }

        public string Edible {get; set;}

        public string Review { get; set; } 

       // [StringLength(30)]
        public string Color { get; set; }

      //  [Range(1, 20)]
       // [DataType(DataType.Currency)]
        //[Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }

    Models -> Class -> flags.cs
    
    
    
    ______██████████████
-____██▓▓▓▓▓▓▓▓▓ M ▓████
-__██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██
-__██████░░░░██░░██████
██░░░░████░░██░░░░░░░░██
██░░░░████░░░░██░░░░░░██
-__████░░░░░░██████████
-__██░░░░░░░░░░░░░██
_____██░░░░░░░░░██
-______██░░░░░░██
-____██▓▓████▓▓▓█
-_██▓▓▓▓▓▓████▓▓█
██▓▓▓▓▓▓███░░███░
-__██░░░░░░███████
-____██░░░░███████
-______██████████
-_____██▓▓▓▓▓▓▓▓▓██
-_____█████████████


    12:37pm - updated the startup.cs to  public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<MvcFlagsContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("MvcFlagsContext")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<MvcFlagsContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();

12:38 pm added an mvcFlags context.cs into the data folder.


12:41pm added "Server=(localdb)\\mssqllocaldb;Database=MvcFlagsContext-1;Trusted_Connection=True;MultipleActiveResultSets=true" to appsetting.json

12:52 pm added a scaffolding by right clicking controllers and going into MVC Controller with views, using Entity Framework > Add.


1:45pm had a hard time accessing the Crud pages but eventually changed the asp controller to Flags which lead me to the crud pages needed for the project.


1:52pm Created a SeedData under models.

2:03pm creating SeedData for the visitors to see 7 different attributes for the product I'm selling.
       I will make a product name, review, price, release date, size, color, and if the product is edible or not.



──────────────███████──███████
──────────████▓▓▓▓▓▓████░░░░░██
────────██▓▓▓▓▓▓▓▓▓▓▓▓██░░░░░░██
──────██▓▓▓▓▓▓████████████░░░░██
────██▓▓▓▓▓▓████████████████░██
────██▓▓████░░░░░░░░░░░░██████
──████████░░░░░░██░░██░░██▓▓▓▓██
──██░░████░░░░░░██░░██░░██▓▓▓▓██
██░░░░██████░░░░░░░░░░░░░░██▓▓██
██░░░░░░██░░░░██░░░░░░░░░░██▓▓██
──██░░░░░░░░░███████░░░░██████
────████░░░░░░░███████████▓▓██
──────██████░░░░░░░░░░██▓▓▓▓██
────██▓▓▓▓██████████████▓▓██
──██▓▓▓▓▓▓▓▓████░░░░░░████
████▓▓▓▓▓▓▓▓██░░░░░░░░░░██
████▓▓▓▓▓▓▓▓██░░░░░░░░░░██
██████▓▓▓▓▓▓▓▓██░░░░░░████████
──██████▓▓▓▓▓▓████████████████
────██████████████████████▓▓▓▓██
──██▓▓▓▓████████████████▓▓▓▓▓▓██
████▓▓██████████████████▓▓▓▓▓▓██
██▓▓▓▓██████████████████▓▓▓▓▓▓██
██▓▓▓▓██████████──────██▓▓▓▓████
██▓▓▓▓████──────────────██████
──████


2:05pm   new Flags
                    {
                        ProductName = "New Orleans Flag",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Size = "Big",
                        Edible = "yes",
                        Review = "Excellent",
                        Color = "Purple",
                        Price = 200.00M
                    },

2:17pm finished adding all of the seedData and wow did that take long... SHESSSSSSSSSSSSSSSSSSSSSSSSHHHHHHHHHHHHHHHHHHHHH

Date: 10 13 2022

11:30 pm  - Had to get my project from github / cloned repository into this cpu now I can start and continue where I left off!

12:20PM - ADDED display name Release date instead of ReleaseDate to flag.cs and added currency and datatype to the seeddata


1:13 pm added a rating system to my project bad being the worst average being average and excellent being great quality.
     Updated migrations


1:54 pm added an image to about us <img src="~/Img/pizzaflag.png" />

2:02pm added another image <img src="~/Img/stoneflag.png" /> to the index home page


2:13pm I changed the font of the front page to make the brand stick out a bit more.

5:25pm  Added a bunch of images that I created on paint and linked them to the about us page and the home page.

6:00pm I updated the css page by adding colors background colors gradients pictures.


9:05pm I updated the fonts again to make it look a little better and centered the text and pictures along with the h1 element to make it look like a button.


10/14/2022

3:04pm updated css adding background color text color etc. Found a beautiful gradient with zig zags and salmon mixed with grey to entertain the visitors.



                                         !!!!!!!!!!!!!!!!!!!TIME FOR ALL ThE CHARTS!!!!!!!!!!!!!!!!!!!
                                                       ──────────────────────────────────  
                                                       

──────▄▀▀▄────────────────▄▀▀▄────
─────▐▒▒▒▒▌──────────────▌▒▒▒▒▌───
─────▌▒▒▒▒▐─────────────▐▒▒▒▒▒▐───                     
────▐▒▒▒▒▒▒▌─▄▄▄▀▀▀▀▄▄▄─▌▒▒▒▒▒▒▌──
───▄▌▒▒▒▒▒▒▒▀▒▒▒▒▒▒▒▒▒▒▀▒▒▒▒▒▒▐───
─▄▀▒▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌───
▐▒▒▒▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐───
▌▒▒▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌──
▒▒▐▒▒▒▒▒▒▒▒▒▄▀▀▀▀▄▒▒▒▒▒▄▀▀▀▀▄▒▒▐──
▒▒▌▒▒▒▒▒▒▒▒▐▌─▄▄─▐▌▒▒▒▐▌─▄▄─▐▌▒▒▌─
▒▐▒▒▒▒▒▒▒▒▒▐▌▐█▄▌▐▌▒▒▒▐▌▐█▄▌▐▌▒▒▐─
▒▌▒▒▒▒▒▒▒▒▒▐▌─▀▀─▐▌▒▒▒▐▌─▀▀─▐▌▒▒▒▌
▒▌▒▒▒▒▒▒▒▒▒▒▀▄▄▄▄▀▒▒▒▒▒▀▄▄▄▄▀▒▒▒▒▐
▒▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▄▄▄▒▒▒▒▒▒▒▒▒▒▒▐
▒▌▒▒▒▒▒▒▒▒▒▒▒▒▀▒▀▒▒▒▀▒▒▒▀▒▀▒▒▒▒▒▒▐ ------------   ( Wanna buy some flags????)
▒▌▒▒▒▒▒▒▒▒▒▒▒▒▒▀▒▒▒▄▀▄▒▒▒▀▒▒▒▒▒▒▒▐
▒▐▒▒▒▒▒▒▒▒▒▒▀▄▒▒▒▄▀▒▒▒▀▄▒▒▒▄▀▒▒▒▒▐
▒▓▌▒▒▒▒▒▒▒▒▒▒▒▀▀▀▒▒▒▒▒▒▒▀▀▀▒▒▒▒▒▒▐
▒▓▓▌▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌
▒▒▓▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌─
▒▒▓▓▀▀▄▄▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐──
▒▒▒▓▓▓▓▓▀▀▄▄▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▄▄▀▀▒▌─
▒▒▒▒▒▓▓▓▓▓▓▓▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▒▒▒▒▒▐─
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌
▒▒▒▒▒▒▒█▒█▒█▀▒█▀█▒█▒▒▒█▒█▒█▒▒▒▒▒▒▐
▒▒▒▒▒▒▒█▀█▒█▀▒█▄█▒▀█▒█▀▒▀▀█▒▒▒▒▒▒▐
▒▒▒▒▒▒▒▀▒▀▒▀▀▒▀▒▀▒▒▒▀▒▒▒▀▀▀▒▒▒▒▒▒▐
█▀▄▒█▀▄▒█▀▒█▀█▒▀█▀▒█▒█▒█▒█▄▒█▒▄▀▀▐
█▀▄▒█▀▄▒█▀▒█▄█▒▒█▒▒█▀█▒█▒█▀██▒█▒█▐
▀▀▒▒▀▒▀▒▀▀▒▀▒▀▒▒▀▒▒▀▒▀▒▀▒▀▒▒▀▒▒▀▀▐
▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐

                                                                       




                                                       

{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}
{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}{}


Chart of the steps I took for this project:

_____________________________         
\          Step 1           /                                                   
 \                         /
  \                       /                                                                          
   \                     /
    \___________________/
              |
              |
1) Create an ASP.NET Core 3.1 application with the assigned product using Visual Studio 2019:

Include Individual User Accounts authentication and configure for HTTPS.
As you begin the assignment in VS19 create a Github repository (Git > Create Git repository...) to backup your application.
See links for additional details (as demonstrated in-class):
https://docs.microsoft.com/en-us/visualstudio/version-control/git-with-visual-studio?view=vs-2019
https://docs.microsoft.com/en-us/learn/modules/visual-studio-github-push/
(This is required as a complete submission).
    
              |
              |
              |
              |
              |
_____________________________         
\          Step 2           /
 \                         /
  \                       /          
   \                     /
    \___________________/
    
    2) Modify the title of the Project page to reflect your fictional company name with a link to navigate to the product catalogue page.

Add an additional link to an 'About Us' page describing the fictional company, corporate headquarters, staff and general description of the product.
Customize the project to include product images, modification of the default style, present unique colour preferences, even font (the default is not acceptable).
Add at least ten(10) product items when seeding the database (Model > SeedData.cs).
Note: The database must provide a minimum of 6 attributes and characteristics of the product (e.g. name, price, etc.) and include an additional customer review based on a half-rating scale of 1-5 (poor to excellent).
              |
              |
              |
              |                                                                                             
_____________________________         
\          Step 3           /
 \                         /
  \                       /          
   \                     /
    \___________________/
    
    3) Submission includes a 'robust' README (external GitHub README with details of the project and product investigation, and internal, detailing the process of building the application with dates/times) and include any additional documentation (e.g. flowcharts).
*Do not forget to liberally comment your code.    
              |
              |
              |
              |
_____________________________         
\          Step 4           /
 \                         /
  \                       /                                                                          
   \                     /
    \___________________/ 
    
    4) Submission in the form of one shared Github repository URL (Recommend to "Change repository visibility" > Make Public) submitted via Blackboard.
This also includes the 'optional' URL to the application running on Azure as demo'd in-class: Publish a Web app to Azure App Service using Visual Studio

* Make sure to read and review the Rubric prior to submitting.
 
    
    
    
    
    
    ALL DONE!!!

__________________▄▄▄▀▀▀▀▀▀▀▄
_______________▄▀▀____▀▀▀▀▄____█
___________▄▀▀__▀▀▀▀▀▀▄___▀▄___█
__________█▄▄▄▄▄▄_______▀▄__▀▄__█
_________█_________▀▄______█____█_█
______▄█_____________▀▄_____▐___▐_▌
______██_______________▀▄___▐_▄▀▀▀▄
______█________██_______▌__▐▄▀______█
______█_________█_______▌__▐▐________▐
_____▐__________▌_____▄▀▀▀__▌_______▐_____________▄▄▄▄▄▄
______▌__________▀▀▀▀________▀▀▄▄▄▀______▄▄████▓▓▓▓▓▓▓███▄
______▌____________________________▄▀__▄▄█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▄
______▐__________________________▄▀_▄█▓▓▓▓▓▓▓▓▓▓_____▓▓____▓▓█▄
_______▌______________________▄▀_▄█▓▓▓▓▓▓▓▓▓▓▓____▓▓_▓▓_▓▓__▓▓█
_____▄▀▄_________________▄▀▀▌██▓▓▓▓▓▓▓▓▓▓▓▓▓__▓▓▓___▓▓_▓▓__▓▓█
____▌____▀▀▀▄▄▄▄▄▄▄▄▀▀___▌█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓__▓________▓▓___▓▓▓█
_____▀▄_________________▄▀▀▓▓▓▓▓▓▓▓█████████████▄▄_____▓▓__▓▓▓█
_______█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▄▄___▓▓▓▓▓█
_______█▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓▓███▓▓▓▓████▓▓▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓█
________█▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▓█▓▓██░░███████░██▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓█
________█▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▓░░░░░█░░░░░██░░░░██▓▓▓▓▓▓▓▓▓██▓▓▓▓▌
________█▓▓▓▓▓▓▓▓▓▓▓▓▓▓███░░░░░░░░____░██░░░░░░░██▓▓▓▓▓▓▓██▓▓▌
________▐▓▓▓▓▓▓▓▓▓▓▓▓▓▓██░░░░░░░________░░░░░░░░░██████▓▓▓▓▓█▓▌
________▐▓▓▓▓▓▓▓▓▓▓▓▓▓▓██░░░░░░___▓▓▓▓▓░░░░░░░███░░███▓▓▓▓▓█▓▌
_________█▓▓▓▓▓▓▓▓▓▓▓▓▓██░░░░░___▓▓█▄▄▓░░░░░░░░___░░░░█▓▓▓▓▓█▓▌
_________█▓▓▓▓▓▓▓▓▓▓▓▓▓█░░█░░░___▓▓██░░░░░░░░▓▓▓▓__░░░░█▓▓▓▓██
_________█▓▓▓▓▓▓▓▓▓▓▓▓▓█░███░░____▓░░░░░░░░░░░█▄█▓__░░░░█▓▓█▓█
_________▐▓▓▓▓▓▓▓▓▓▓▓▓▓█░█████░░░░░░░░░░░░░░░░░█▓__░░░░███▓█
__________█▓▓▓▓▓▓▓▓▓▓▓▓█░░███████░░░░░░░░░░░░░░░▓_░░░░░██▓█
__________█▓▓▓▓▓▓▓▓▓▓▓▓█░░░███████░░░░░░░░░░░░░░_░░░░░██▓█
__________█▓▓▓▓▓▓▓▓▓▓▓▓█░░░███████░░░░░░░░░░░░░░░░░░░██▓█
___________█▓▓▓▓▓▓▓▓▓▓▓▓█░░░░███████░░░░░░░░░░░█████░██░
___________█▓▓▓▓▓▓▓▓▓▓▓▓█░░░░░░__███████░░░░░███████░░█░░
___________█▓▓▓▓▓▓▓▓▓▓▓▓▓█░░░░░░█▄▄▄▀▀▀▀████████████░░█░
___________▐▓▓▓▓▓▓▓▓▓▓▓▓█░░░░░░██████▄__▀▀░░░███░░░░░█
___________▐▓▓▓▓▓▓▓▓▓▓▓█▒█░░░░░░▓▓▓▓▓███▄░░░░░░░░░░░____________▄▄▄
___________█▓▓▓▓▓▓▓▓▓█▒▒▒▒█░░░░░░▓▓▓▓▓█░░░░░░░░░░░______▄▄▄_▄▀▀____▀▄
__________█▓▓▓▓▓▓▓▓▓█▒▒▒▒█▓▓░░░░░░░░░░░░░░░░░░░░░____▄▀____▀▄_________▀▄
_________█▓▓▓▓▓▓▓▓▓█▒▒▒▒█▓▓▓▓░░░░░░░░░░░░░░░░░______▐▄________█▄▄▀▀▀▄__█
________█▓▓▓▓▓▓▓▓█▒▒▒▒▒▒█▓▓▓▓▓▓▓░░░░░░░░░____________█_█______▐_________▀▄▌
_______█▓▓▓▓▓▓▓▓█▒▒▒▒▒▒███▓▓▓▓▓▓▓▓▓▓▓█▒▒▄___________█__▀▄____█____▄▄▄____▐
______█▓▓▓▓▓▓▓█_______▒▒█▒▒██▓▓▓▓▓▓▓▓▓▓█▒▒▒▄_________█____▀▀█▀▄▀▀▀___▀▀▄▄▐
_____█▓▓▓▓▓██▒_________▒█▒▒▒▒▒███▓▓▓▓▓▓█▒▒▒██________▐_______▀█_____________█
____█▓▓████▒█▒_________▒█▒▒▒▒▒▒▒▒███████▒▒▒▒██_______█_______▐______▄▄▄_____█
__█▒██▒▒▒▒▒▒█▒▒____▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒____▒█▓█__▄█__█______▀▄▄▀▀____▀▀▄▄█
__█▒▒▒▒▒▒▒▒▒▒█▒▒▒████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█_______█▓▓█▓▓▌_▐________▐____________▐
__█▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒_______█▓▓▓█▓▌__▌_______▐_____▄▄____▐
_█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒_____█▓▓▓█▓▓▌__▌_______▀▄▄▀______▐
_█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███████▓▓█▓▓▓▌__▀▄_______________▄▀
_█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒▒▒▒██▓▓▓▓▓▌___▀▄_________▄▀▀
█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒█▓▓▓▓▓▀▄__▀▄▄█▀▀▀
█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▓▓▓▓██▄▄▄▀
█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒████
█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
_█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▄▄▄▄▄
_█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒▒▒██▄▄
__█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒███▒▒▒▒▒▒▒▒▒▒▒▒▒█▄
__█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
__█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
___█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▌
____█▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒░░░░░░░░░░░░░▒▒▌
____█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█████████████▒▒▒▒▒█▒▒▒▒▒▒▒▒░░░░▒▒▒▒▒▒▒▒▒▒▒░▒▌
_____█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█_______▐▒▒▒▒█▒▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▌
______█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█________█▒▒█▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌
_______█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█________█▒█▒▒▒▒▒▒░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌
________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█________█▒▒▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
_________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█________█▒▒▒▒░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
_________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█________█▒▒▒░░░░░░░▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▀
__________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█_______█▒░░░▒▒▒▒▒░░░░░░░░▒▒▒█▀▀▀
___________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█_______█░▒▒▒▒▒▒▒▒▒▒▒▒▒░░░░█▀
____________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█_______█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▀
_____________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█_______█▒▒▒▒▒▒▒▒▒▒▒▒█▀
_____________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█_______▀▀▀███████▀▀
______________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
_______________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
_________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
__________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒█
___________________█▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒▒█
___________________█▒▒▒▒▒▒▒▒████▒▒▒▒▒▒▒█
___________________█████████▒▒▒▒▒▒▒▒▒▒▒█
____________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
____________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█
_____________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▌
_____________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░▌
______________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░▌
_______________________█▒▒▒▒▒▒▒▒▒▒▒▒▒▒░░█
________________________█▒▒▒▒▒▒▒▒▒▒▒░░░█
__________________________██▒▒▒▒▒▒░░░█▀
_____________________________█░░░░░█▀
_______________________________▀▀▀▀

    
    

