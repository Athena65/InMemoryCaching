# InMemoryCaching
In Memory Caching is Powerful tool for optimize the performance of an application (makes faster response for Back Service!)  . 
Required Packages: Microsoft.EntityFrameworkCore.InMemory , For Migration:  Microsoft.EntityFrameworkCore.Sql.Server , Microsoft.EntityFrameworkCore.Tools  , Bogus for fake vehicle objects and Scrutor.AspNetCore
First Result without caching into memory:
![first 1977ms](https://user-images.githubusercontent.com/41066333/213500004-ec13236b-46ed-411a-8d96-54b0562f2a68.png)
Second Result after caching into memory:
![second 93ms](https://user-images.githubusercontent.com/41066333/213500102-b6e3cba4-60ab-446c-a423-dfe13d24b4df.png)

