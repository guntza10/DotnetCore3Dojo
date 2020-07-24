# Dotnet Core 3

## Architecture
> `1.` Program.cs -> เป็น entry point ของ dotnet application เมื่อ run dotnet application มันจะเข้ามาที่นี่เป็นที่แรก ทำงานใน method main เรียกใช้ CreateHostBuilder -> Stratup.cs
>
>![program](images\ProgramCs.png)

>`2.` Startup.cs -> เป็นส่วน core ศูนย์กลางในการทำงานของ dotnet application เอาไว้สำหรับ set config ต่างๆเกี่ยวกับการเชื่อมต่อพวก service , Http request
>
>![startUp](images\StartupCs.png)

>`3.` .csproj -> เป็นส่วนที่เอาไว้บอกว่า project เรามีการใช้ package , nuget , library ตัวไหนบ้าง รวมถึงบอก version ของ dotnet core 
>
>![csProj](images\csProj.png)

>`4.` appsettings.json -> เป็นส่วนที่เอาไว้เพิ่ม additional config หรือ connetion string
>
>![appsetting](images\appSetting.png)

## REST & RESTFUL API
> `REST (Representational State Transfer)` -> เป็นรูปแบบของ software architecture ที่ใช้ web protocol(HTTP) ในการสร้าง web service

>`RESTFUL API (RESTFUL)` -> Web Service ที่ใช้ REST ในการสร้าง(ใช้ HTTP GET,POST,PUT,DELETE ในการ request และ response กลับมาในรูปแบบของ JSON หรือ XML ระหว่าง client กับ server)

## Controller
