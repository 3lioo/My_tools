user = "4dminUser31337"
result= ""
for i in user :
    
    ch = ord(i)
    if ch%2 == 0 :
        k = "-"
    else :
        k = "+"
        ch = ch - 1
    ch = ch // 2
    result += (hex(ch) + k).strip("0x")
print(result)

