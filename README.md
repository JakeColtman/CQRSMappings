# CQRSMappings
A sketch for a feature of my game engine. 

I wanted to test implementing CQRS in practice, so the display of the data and the writing of the data are separate processes.  This is to solve the problems that I've had combining the two into one coherent system

On the Q side, I've created a IProjection interface which is used to project the underlying data in a number of ways:

  Occupied squares
  Threatened Squares
  Actual objects
  
The projections will become more than just views, the idea is to use the projections to add rules to the game.  Rather than having one big dump of rules, you can tie rules to a specific way of thinking about the game.  This is good not only for organization but also for greatly narrowing the semantic and syntacic complexity of rules
