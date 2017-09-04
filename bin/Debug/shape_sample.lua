inner_range = 320
outer_range = 400
inner_angle_ratio = 0.4
outer_angle_ratio = 0.2
steps = 20

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
  l1=line(x1, y1, 0, x2, y2, 0)

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

  f1=makeface(l1);
  extrude(f1, 200)