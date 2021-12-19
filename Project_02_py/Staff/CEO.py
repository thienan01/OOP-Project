from Staff.Person import Person
class CEO(Person):
    def __init__(self, name, cmnd, yOfBirth, baseSalary, position,department,numOfContract):
        super().__init__(name, cmnd, yOfBirth, baseSalary, position)
        self.Department = department
        self.NumOfContract = numOfContract

    def Salary(self):
        return self.BaseSalary + self.NumOfContract*10000000
    
    def Info(self):
        super().Info()
        print("Name: " + self.Name)
        print("CMND: " + self.CMND)
        print("Year of birth: " + str(self.YearOfBirth))
        print("Position : " + self.Position)
        print("number of contracts: " + str(self.NumOfContract))
        print("Salary: " + str(self.Salary()))
        print("Department: " + self.Department)
        print("--------------------------------------------")
