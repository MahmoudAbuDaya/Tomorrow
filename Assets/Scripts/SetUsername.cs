﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUsername {

	// It's saving the passed username
	public void call (string username) {
		DataController.Instance.player_data.username = username;
		DataController.Instance.Save();
	}

}
