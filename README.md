# A zero configuration minimal and liteweight ASP.net Core URL shortener
This web app **requires `ASP.net Core 3`** or later.  
For **ASP.net core under v3** you need to change `services.AddRazorPages();` in line 19 and `endpoints.MapRazorPages();` in line 34 of **`startup.cs`** file.  


> --------------------------------
### Directory Structure:  
Directory / File | Explanation 
--------- | -----------
/BLL | Contains a class, that used to **read last Database ID** from `lastRecord.txt` file (located in Project's root) and **+1 it, then write it back to file and also return it as `string`** 
/Static_Assets | Contains css, js, images and fonts *[1]*
urlData.litedb | This is a liteDB database file which is safe to remove/ It will be recreated in runtime!
lastRecord.txt | This *4B* sized file, storing last value of `urlShortner.Models.urlData.shortUrl` inserted to the database, which is used as `ID field` for database *[2]*


> Other files are based on ASP.net core's directory structure.   

> *[1]:* If you having problem accessing these files (such as background doesn't load or bootstrap.css errors) add following lines to the `web.config` file located in **publish** folder:  
> add `<location>` tag directly under `<configuration>` tag.
```XML
<location path="Static_assets">
  <system.webServer>
    <directoryBrowse enabled="true" />
  </system.webServer>
</location>
```
> *[2]:* This file's **initial value is `` aa` ``** because `urlShortner.Bll.shortUrlCreator.shortner(string filePath)` +1 the value, everytime it reads the file. So this way, first `shortUrl` will be `aaa`  
> This property is located in: `/models/urlData.cs`  


> --------------------------------
### Short URLs life time:
Any single URL **will lives until 999 new URL added!**  
**Reason is that `Upsert()` function is used** to add new URL to database in the `DbCollection.Upsert(urlDataObj);` code line.  


> --------------------------------
### Current short URLs range:
from `aaa` to `zzz`.  
No uppercase URLs; No numbers...!


> --------------------------------
### ToDo:
- [ ] Edit source code of `/BLL` to start from `aaa` after riched `~~~` value in `lastRecord.txt`
- [ ] Fix issue of `longUrl`s which are not starting with `http://` or `https://`
- [ ] Make **Domain name prefix** before shortUrl that showing to the client, Dynamic!
- [ ] Fix issue that **client is able to shorten a single URL, multiple times!**
- [ ] Change `/BLL` source code to make `shortUrl` string's length configurable by admin! /(still zero config?)*
- [ ] Implement shoert URLs' hit times monitor
- [ ] **show corresponding errors** when requested `shortUrl` doesn't exist or when clien tries to shorten empty `longUrl`
- [ ] Randomize background image
- [ ] Add documentaion comments to source code
