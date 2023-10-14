using BuilderExample;

Person person = new PersonBuilder()
    .SetName("John Doe")
    .SetAge(30)
    .SetAddress("123 Main Street")
    .SetEmail("john@example.com")
    .Build();