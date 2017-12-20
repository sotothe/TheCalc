def calc(s):
    try:
        s = str(eval(s))
    except:
        s = "Error"
    return s