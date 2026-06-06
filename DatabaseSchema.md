# LMS Database Schema

## Overview

Learning Management System (LMS) database schema designed using Clean Architecture principles.

---

# ApplicationUser

Stores all system users.

| Column       | Type         | Constraints      |
| ------------ | ------------ | ---------------- |
| Id           | UUID         | PK               |
| FirstName    | VARCHAR(100) | NOT NULL         |
| LastName     | VARCHAR(100) | NOT NULL         |
| Email        | VARCHAR(255) | UNIQUE, NOT NULL |
| PasswordHash | TEXT         | NOT NULL         |
| Role         | VARCHAR(50)  | NOT NULL         |
| CreatedAt    | TIMESTAMP    | NOT NULL         |

### Role Values

* Admin
* Instructor
* Student

---

# Course

Stores course information.

| Column       | Type         | Constraints |
| ------------ | ------------ | ----------- |
| Id           | UUID         | PK          |
| Title        | VARCHAR(200) | NOT NULL    |
| Description  | TEXT         | NOT NULL    |
| InstructorId | UUID         | FK          |
| CreatedAt    | TIMESTAMP    | NOT NULL    |

### Foreign Keys

```text
InstructorId → ApplicationUser.Id
```

### Relationship

```text
ApplicationUser (Instructor)
1 -------- * Course
```

---

# Enrollment

Stores student enrollments in courses.

| Column         | Type        | Constraints |
| -------------- | ----------- | ----------- |
| Id             | UUID        | PK          |
| StudentId      | UUID        | FK          |
| CourseId       | UUID        | FK          |
| EnrollmentDate | TIMESTAMP   | NOT NULL    |
| Status         | VARCHAR(50) | NOT NULL    |

### Status Values

* Active
* Completed
* Dropped

### Foreign Keys

```text
StudentId → ApplicationUser.Id

CourseId → Course.Id
```

### Relationship

```text
ApplicationUser (Student)
1 -------- * Enrollment

Course
1 -------- * Enrollment
```

### Unique Constraint

```text
(StudentId, CourseId)
```

A student cannot enroll in the same course more than once.

---

# Assignment

Stores course assignments.

| Column      | Type         | Constraints |
| ----------- | ------------ | ----------- |
| Id          | UUID         | PK          |
| Title       | VARCHAR(200) | NOT NULL    |
| Description | TEXT         | NOT NULL    |
| DueDate     | TIMESTAMP    | NOT NULL    |
| CourseId    | UUID         | FK          |
| CreatedAt   | TIMESTAMP    | NOT NULL    |

### Foreign Keys

```text
CourseId → Course.Id
```

### Relationship

```text
Course
1 -------- * Assignment
```

---

# Submission

Stores assignment submissions.

| Column       | Type         | Constraints |
| ------------ | ------------ | ----------- |
| Id           | UUID         | PK          |
| AssignmentId | UUID         | FK          |
| StudentId    | UUID         | FK          |
| FileUrl      | TEXT         | NOT NULL    |
| SubmittedAt  | TIMESTAMP    | NOT NULL    |
| Grade        | DECIMAL(5,2) | NULL        |
| Feedback     | TEXT         | NULL        |

### Foreign Keys

```text
AssignmentId → Assignment.Id

StudentId → ApplicationUser.Id
```

### Relationships

```text
Assignment
1 -------- * Submission

ApplicationUser (Student)
1 -------- * Submission
```

### Unique Constraint

```text
(StudentId, AssignmentId)
```

A student can submit only one submission for a specific assignment.

---

# Database Relationships Summary

```text
ApplicationUser (Instructor)
1 -------- * Course

ApplicationUser (Student)
1 -------- * Enrollment

Course
1 -------- * Enrollment

Course
1 -------- * Assignment

Assignment
1 -------- * Submission

ApplicationUser (Student)
1 -------- * Submission
```

---

# Notes

* PostgreSQL Database Provider
* Entity Framework Core ORM
* ASP.NET Core Identity will be integrated later
* Clean Architecture Project Structure
* UUID will be represented as Guid in C#
