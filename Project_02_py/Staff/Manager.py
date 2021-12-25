from Staff.Person import Person
class Manager(Person):
    def __init__(self, name, cmnd, yOfBirth, baseSalary, position, overTime):
        super().__init__(name, cmnd, yOfBirth, baseSalary, position)
        self.OverTime = overTime

    def  Salary(self):
        return self.BaseSalary + self.OverTime*200000
    
    def Info(self):
        super().Info()
        print("Name: " + self.Name)
        print("CMND: " + self.CMND)
        print("Year of birth: " + str(self.YearOfBirth))
        print("Position : " + self.Position)
        print("Over time: " + str(self.OverTime)) 
        print("Salary: " + str(self.Salary()))
        print("--------------------------------------------")
