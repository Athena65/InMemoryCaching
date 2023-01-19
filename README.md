# InMemoryCaching
In Memory Caching is Powerful tool for optimize the performance of an application (makes faster response for Back Service!)  . 
Required Packages: Microsoft.EntityFrameworkCore.InMemory , For Migration:  Microsoft.EntityFrameworkCore.Sql.Server , Microsoft.EntityFrameworkCore.Tools  , Bogus for fake vehicle objects and Scrutor.AspNetCore
First Result without caching:
![first 1977ms](https://user-images.githubusercontent.com/41066333/213496634-96648843-4469-4f99-a37a-d00cb0c20852.png)
Second Result after caching:
![second 93ms](https://user-images.githubusercontent.com/41066333/213496640-84c29c01-b0de-49a6-8d1b-0eb3d87ebecd.png)
