About
================

This is to answer [this question](http://stackoverflow.com/questions/9994555/partial-classes-lost-through-a-webservice-reference/9994844#9994844) on StackOverflow.

This demonstrates the following:

 - Adding a service reference in one project
 - Adding a partial class in service reference hosting project
 - Referencing the project from multiple other projects
 - Using both the partial and the service
 
Remember to add the same references needed by the project hosting the service reference to the using projects, or it won't compile. This solution is a good, working example.

-- [Chris Benard](http://chrisbenard.net?rel=author)