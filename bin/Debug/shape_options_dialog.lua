beginArgumentSection("Gear")
addArgumentReal("Inner Range", "Inner angle", 320)
addArgumentReal("Outer Range", "Outer Range", 400)
addArgumentReal("Inner Angle Ratio", "Inner Angle Ratio", 0.4)
addArgumentReal("Outer Angle Ratio", "Outer Angle Ratio", 0.2)
addArgumentInteger("Steps", "Gear Steps", 20)
showArguments()

inner_range = getArgumentReal("Inner Range")
outer_range = getArgumentReal("Outer Range")
inner_angle_ratio = getArgumentReal("Inner Angle Ratio")
outer_angle_ratio = getArgumentReal("Outer Angle Ratio")
steps = getArgumentInteger("Steps")


_2pi = 2*pi()
radStep = _2pi/steps
degToRad = 180 / pi()

angle_ratio_start = inner_angle_ratio + (1.0 - inner_angle_ratio - outer_angle_ratio) / 2  

x1 = 0
y1 = 0
x4 = 0
y4 = 0

second_line = false
i = 0

while(i < steps) do
  x1 = cos(radStep * i) * inner_range
  y1 = sin(radStep * i) * inner_range
  x2 = cos(radStep * (i+inner_angle_ratio)) * inner_range
  y2 = sin(radStep * (i+inner_angle_ratio)) * inner_range
  line(x1, y1, 0, x2, y2, 0)

  if(second_line) then
    line(x4, y4, 0, x1, y1, 0)
  else 
    second_line = true 
  end

  x3 = cos(radStep * (i + angle_ratio_start)) * outer_range
  y3 = sin(radStep * (i + angle_ratio_start)) * outer_range
  x4 = cos(radStep * (i + angle_ratio_start + outer_angle_ratio)) * outer_range
  y4 = sin(radStep * (i + angle_ratio_start + outer_angle_ratio)) * outer_range
  line(x3, y3, 0, x4, y4, 0)

  line(x2, y2, 0, x3, y3, 0)

  i = i + 1
end


  x1 = cos(radStep * i) * inner_range
  y1 = sin(radStep * i) * inner_range
  line(x4, y4, 0, x1, y1, 0)

  makeface(shape("Line-"));
  extrude(shape("Face-"), 200)