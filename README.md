# CalculatorMVC-SolbegSoft-
                                                                         User's Guide
1. To use the calculator, you need to go to the url - https://localhost:44376/Home


2. On the page you will see an input field Illustration 1.1. In it you can write your example using the keyboard, as well as use the auxiliary buttons figure 1.2
 
 
  ![Image alt](https://github.com/Overlord-12/CalculatorMVC-SolbegSoft-/raw/master/CalculatorMVC(SolbegSoft)/Images/Image1.png)
  
Illustration 1.1(Input field)
 
 
 ![Image alt](https://github.com/Overlord-12/CalculatorMVC-SolbegSoft-/raw/master/CalculatorMVC(SolbegSoft)/Images/Image2.png)
 
 Illustration 1.2(Helper button)
 
3. After you have entered your example, you should click the ( = ) or press enter on your keyboard (Illustration button 1.3)
 
  ![Image alt](https://github.com/Overlord-12/CalculatorMVC-SolbegSoft-/raw/master/CalculatorMVC(SolbegSoft)/Images/Image3.png)
 
Illustration 1.3(Button)

4. After you click this button, the result will appear Illustration 1.4. Then you can continue the calculations with this result or use the C button, which will clear your calculations (Illustration 1.5), and then you can create a new example 
 
  ![Image alt](https://github.com/Overlord-12/CalculatorMVC-SolbegSoft-/raw/master/CalculatorMVC(SolbegSoft)/Images/Image4.png)
 
Illustration 1.4(Result)
 
 ![Image alt](https://github.com/Overlord-12/CalculatorMVC-SolbegSoft-/raw/master/CalculatorMVC(SolbegSoft)/Images/Image5.png)
 
Illustration 1.5(Button clear)

5.  Also on the page on the left there is an instruction for use, which can help if a difficult situation.

                                                                  Application Architecture 
                                                                  
1.  The application consists of 1 model, 1 controller, 1 view. There is also a js code that performs simple calculations, and there is also a style sheet
2.  CalcModel contains the example property, which stores the expression necessary to calculate. There is also a 
    Calculate method in the model, which is used to perform computational operations.
3.  Controller contains there are two methods Index, which does not accept values and an overloaded version of Index(CalcModel calc). This method parses the string into digits, 
    and then performs the necessary calculations and returns the View.
4.  The view contains a single Index page. It is used to perform calculations and contains one field for entering an example and 6.
5.  The application has a Site style file. It is used to configure buttons and other elements
6.  The last file is the js code that is used for fast calculations on the page.
7. The calculator can use the operations /,*,+, -. It is able to calculate fractional numbers.
                                                                  
