// College -> Student, Teacher

using System;
//but this namespace is accessible to any other files in the same project.
// the source file can contain only one file-scoped namespace declaration. 
namespace College;

using System.Linq;

//namespace myOtherNamespace; // this is not possible

class Student
{

}

class Teacher
{

}

// Source file can not contain both file-scoped namespace and normal namespace declarations.
/*
namespace regularNameSpace
{

}
*/