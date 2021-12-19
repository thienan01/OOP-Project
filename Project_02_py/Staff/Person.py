class Person:
    def __init__(self, name, cmnd, yOfBirth,baseSalary, position):
        self.Name = name
        self.CMND  = cmnd
        self.YearOfBirth = yOfBirth
        self.BaseSalary = baseSalary
        self.Position = position
    
    def Salary(self):
        return  self.BaseSalary

    def Info(self):
        print("Staff Info:")
