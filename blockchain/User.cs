using System;

enum UserRole : int
{
    Employee = 1,
    Manager = 2,
    Admin = 3
}

namespace blockchain
{
    public struct User
    {
        String email;
        UserRole role;
    }
}
