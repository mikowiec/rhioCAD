s1=Sketch(0,0,0,4,5,0,2,3,0)
EnterSketch(s1)
p1=Point(s1,2,2,0)
p2=Point(s1,10,40,0)
Rectangle(p1,p2)
p3=Point (s1,20,2,0)
p4=Point(s1,40,40,0)
Rectangle(p3,p4)
Extrude(s1,20)
s2=Sketch(0,0,20,4,5,20,2,3,20)
EnterSketch(s2)
p5=Point(s2, 30,20,20)
c1=Circle(p5,15)
Cut(s2,100)