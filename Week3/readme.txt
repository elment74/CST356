To get this to work I initially did 

$docker build -t elment74/myfirstapp .

and then 

$docker run -p 8080:80 --name myfirstapp elment74/myfirstapp

What happens now is the console was hanging for me, I'm guessing it was pushing the site online.
I was unable to access the site via localhost:8080 or any of those methods so I had to open another
Docker instance and use

$docker-machine ip default

and use that number in the url as

[number obtained]:8080

If anything is wrong please don't hesistate to inform me.