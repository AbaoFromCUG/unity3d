# Unity3D 学习笔记
### 关于编辑器的使用

### 关于API的

### 关于世界坐标
####  Vector3 
> 这是一个表示三维矢量的类
> 如Vector3 （1，0，0）表示向右移动1个单位

#### 刚体
FixedUpdate（）
> 这是在具有刚体特性的组件，在运动状态改变时被调用
AddForce (Vector3 force, ForceMode mode = ForceMode.Force)
>这让刚体收到force向的力，改变mode可以让force表示脉冲，加速度或者其他
OnTriggerEnter(Collider other) 
>这是刚体碰撞时的方法，传入一个碰撞器other然后可以通过other.gameObject()获取碰撞对象，让后通过CompareTag ("Pick Up")判断该碰撞对象是不是某一tag标签

    
    //在C#类的内部
    void FixedUpdate ()
	{
		// Set some local float variables equal to the value of our Horizontal and Vertical Inputs
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// Create a Vector3 variable, and assign X and Z to feature //our horizontal and vertical float variables above
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		// Add a physical force to our Player rigidbody using our 'movement' Vector3 above, 
		// multiplying it by 'speed' - our public player speed that appears in the inspector
		rb.AddForce (movement * speed);
	}
	// When this game object intersects a collider with 'is trigger' checked, 
	// store a reference to that collider in a variable named 'other'..
	void OnTriggerEnter(Collider other) 
	{
		// ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
		if (other.gameObject.CompareTag ("Pick Up"))
		{
            // Make the other game object (the pick up) inactive, to make it disappear
            other.gameObject.SetActive (false);
            ;

			// Add one to the score variable 'count'
			count = count + 1;

			// Run the 'SetCountText()' function (see below)
			SetCountText ();
		}
	}