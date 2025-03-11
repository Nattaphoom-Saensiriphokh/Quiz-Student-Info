# Quiz-Student-Info

# 1. Class Diagram ของโปรแกรม

@startuml
abstract class Person {
    - ID: string
    - Name: string
    + ToString(): string
}

class Student {
    - Major: string
    - AdvisorName: string
    - GPA: double
    + ToString(): string
}

class Teacher {
    - Major: string
    - advisees: List<Student>
    + AddAdvisee(s: Student)
    + GetAdvisees(): List<Student>
    + ToString(): string
}

Person <|-- Student
Person <|-- Teacher
Teacher "1" o-- "*" Student : advises

@enduml



# 2. โปรแกรมได้ใช้หลักการเขียนโปรแกรมเชิงวัตถุอย่างไรบ้าง

โปรแกรมนี้ได้ใช้แนวคิดของการเขียนโปรแกรมเชิงวัตถุ (OOP) ดังนี้:

# 1.Encapsulation (การห่อหุ้มข้อมูล)

ใช้คลาส Student และ Teacher เพื่อเก็บข้อมูลและจัดการกับนักศึกษาและอาจารย์

มีเมธอด ToString() และ GetAdvisees() เพื่อแสดงผลข้อมูลแทนการเข้าถึงข้อมูลโดยตรง

# 2.Inheritance (การสืบทอดคลาส)

คลาส Student และ Teacher สืบทอดมาจาก Person

Person เป็นคลาสแม่ที่มี ID และ Name ซึ่งสามารถใช้ร่วมกันได้ทั้งนักศึกษาและอาจารย์

# 3.Polymorphism (พหูรูปแบบ)

คลาส Person มีเมธอด ToString() ที่เป็น abstract ซึ่งบังคับให้ Student และ Teacher ต้อง override เมธอดนี้

ช่วยให้สามารถเรียก ToString() ได้จากออบเจ็กต์ Student และ Teacher โดยไม่ต้องรู้รายละเอียดของคลาสที่เป็นลูก

# 4.Abstraction (นามธรรม)

Person เป็น abstract class ที่กำหนดให้ทุกคนต้องมี ID และ Name

ซ่อนรายละเอียดของการจัดเก็บข้อมูลนักศึกษาและอาจารย์ภายในคลาสของตัวเอง

# วิธีใช้งานโปรแกรม

1.กรอกข้อมูลนักศึกษา และเลือกอาจารย์ที่ปรึกษา

2.เพิ่มข้อมูลอาจารย์และตรวจสอบรายชื่อนักศึกษาที่อยู่ในที่ปรึกษา

3.คำนวณและแสดงนักศึกษาที่มี GPA สูงสุด

ผู้พัฒนา

นายณัฐภูมิ แสนศิริโภค 673450189-9
