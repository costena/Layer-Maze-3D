Shader "Custom/test"
{
	properties{
		_Color("Main Color",color)=(1,1,1,1)
		_Amnient("Ambient",color)=(0.3,0.3,0.3,1)
		_Specular("Specular",color)=(1,1,1,1)
		_Shininess("Shininess",range(0,8))=4
		_Emission("Emission",color)=(1,1,1,1)
		_MainTex("MainTex",2d)=""
		_SecTex("MainTex",2d)=""
	}

	SubShader{
		pass {
			material{
				diffuse[_Color]
				ambient[_Amnient]
				specular[_Specular]
				shininess[_Shininess]
				emission[_Emission]
			}
			lighting on
			separatespecular on

			settexture[_MainTex]{
				combine texture * primary double
			}

			settexutre[_SecTex]{
				combine texture * previous double
			}
		}
	}
}
