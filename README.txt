Programmer name: Luis Rodriguez

Company name: Flags4us

Program purpose: To create a program to sell flags and show everyone the types of flags in stock and detail about each flag

Date created: 10/12/2022

Date last edited: 10/*/2022


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
 
 9:37am - I will begin by commenting out the  // "sslPort": 44367 under properties -> launchSettings.json 

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

