#version 150

// Input vertex data, different for all executions of this shader.
in vec3 vertex_pos;

uniform mat4 MVP;

void main(){
  vec4 v = vec4(vertex_pos, 1); // Transform to a homogeneous 3D 
  gl_Position = MVP * v;
}
