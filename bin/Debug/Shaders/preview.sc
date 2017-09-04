% photons {
%   caustics 10000000 kd 64 0.5
% }

shader {
  name "ground"
  type diffuse
  diff 0.800000011921 0.800000011921 0.800000011921
}

include "testshader.sc"


%% common settings

image {
   resolution 256 256
   aa 0 2
}

accel bih
filter mitchell
bucket 32 row


%% camera

camera {
   type pinhole
   eye    3.27743673325 -9.07978439331 9.93055152893
   target 0 0 0
   up     0 0 1
   fov    40
   aspect 1
}


%% light sources

light {
   type meshlight
   name "meshlight"
   emit 1 1 1
   radiance 16
   samples 32
   points 4
      -1.79750967026 -6.22097349167 5.70054674149
      -2.28231739998 -7.26064729691 4.06224298477
      -4.09493303299 -6.41541051865 4.06224298477
      -3.61012482643 -5.37573671341 5.70054721832
   triangles 2
      0 1 2
      0 2 3
}

light {
   type meshlight
   name "meshlight.001"
   emit 1 1 1
   radiance 15
   samples 32
   points 4
      -4.25819396973 -4.8784570694 5.70054674149
      -5.13696432114 -5.61583280563 4.06224298477
      -6.422539711 -4.08374404907 4.06224298477
      -5.54376888275 -3.34636831284 5.70054721832
   triangles 2
      0 1 2
      0 2 3
}


%% geometry

object {
   shader ground
   type generic-mesh
   name "Plane"
   points 8
       16.1  16.1 -4
       16.1 -16.1 -4
      -16.1 -16.1 -4
      -16.1  16.1 -4
      -16.1  16.1 -4.61
      -16.1 -16.1 -4.61
       16.1 -16.1 -4.61
       16.1  16.1 -4.61

   triangles 12
      0 3 2
      0 2 1
      2 3 4
      2 4 5
      3 0 7
      3 7 4
      0 1 6
      0 6 7
      1 2 5
      1 5 6
      5 4 7
      5 7 6
   normals none
   uvs none
}

object {
  shader "shader05"
  type sphere
  c 0 0 0
  r 3.7
}


