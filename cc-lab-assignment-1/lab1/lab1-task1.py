import tkinter as tk
from math import sin, cos, tan, log, radians

# Function to perform calculations
def calculate():
    try:
        expression = entry.get()
        # Evaluate trigonometric functions (input in degrees)
        expression = expression.replace('sin', 'sin(radians(')
        expression = expression.replace('cos', 'cos(radians(')
        expression = expression.replace('tan', 'tan(radians(')
        expression = expression.replace('log', 'log(')
        expression += ')'
        result = eval(expression)
        result_var.set(result)
    except Exception as e:
        result_var.set(f"Error: {e}")

# Create main window
root = tk.Tk()
root.title("Scientific Calculator")

# Create and place widgets
entry = tk.Entry(root, width=40)
entry.pack()

result_var = tk.StringVar()
result_label = tk.Label(root, textvariable=result_var)
result_label.pack()

calculate_button = tk.Button(root, text="Calculate", command=calculate)
calculate_button.pack()

# Start the GUI event loop
root.mainloop()
