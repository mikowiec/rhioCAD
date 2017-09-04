r4=Rectangle(0,0,0,100,100,100,1,0,0)
e1=Extrude(r4,500)
s1 = SubShape(e1, 1)
e2=Extrude(s1,500)

s2 = SubShape(e2, 1)
e3=Extrude(s2,500)

s3 = SubShape(e3, 1)
e4=Extrude(s3,500)
