print("SIMPLE GRADE CALCULATOR")



while True: 
    try: 
        subjects = int(input("How many subjects: ")) 

        if subjects <= 0:
            print("Number of subjects must be greater than 0")
            continue

        count = 1
        total = 0
        
        while count <=  subjects:
            while True:
                grade_input = input("Enter grade " + str(count) + ": ")
                
                if not grade_input.isdigit():
                    print("Grade must be a number.")
                    continue
                
                grade = int(grade_input)            

                if grade < 0 or grade > 100:
                    print("Invalid grade. Enter 0-100 only.")
                    continue
                break
            

            count += 1
            total += grade

        print("---RESULTS---")
        average = total / subjects
        print(f"\nAverage: {average:.2f}")


        if average >= 90:
            status = EXCELLENT
        elif average>= 75: 
            status = GOOD
        else:
            status = NEEDS IMPROVEMENT
        print("STATUS: ", status)

        choice = input("\nrun again? (y/n): ")
        if choice.lower() != 'y':
            break

    except ValueError:
        print("INPUT A NUMBER")
