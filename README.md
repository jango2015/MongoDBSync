# MongoDBSync
Synchronous extensions for the asynchronous MongoDB .NET driver.

This is meant to solve the problem [identified here](https://www.mongodb.com/blog/post/introducing-20-net-driver) - namely, that it's not always reasonable to interact with an asynchronous API. Particularly in the context of a web application.

This is _not_ meant as an endorsement of synchronous programming over asynchronous programming; rather, it's meant to allow a developer to use the mechanism which is best for their purpose.
