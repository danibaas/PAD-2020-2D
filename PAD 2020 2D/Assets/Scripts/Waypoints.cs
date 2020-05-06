﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Waypoints : MonoBehaviour {

    public static Transform[] waypoints;

    private const int _ScreenSizeX = 22;
    private const int _ScreenSizeY = 12;
    private const int _ScreenDivide = 5;
    private const int _ScreenOffset = 11;
    private const int _YMin = -5;
    private const int _YMax = 5;

    void Awake() {
        waypoints = new Transform[transform.childCount];
        for (int i = 0; i < waypoints.Length; i++) {
            waypoints[i] = transform.GetChild(i);
        }
        if (!Interscene.instance.retryLevel) {
            GameObject.Find("WP").transform.position = RandomPosition1();
            GameObject.Find("WP (1)").transform.position = RandomPosition2();
            GameObject.Find("WP (2)").transform.position = RandomPosition3();
        } else {
            GameObject.Find("WP").transform.position = Interscene.instance.waypoints[0];
            GameObject.Find("WP (1)").transform.position = Interscene.instance.waypoints[1];
            GameObject.Find("WP (2)").transform.position = Interscene.instance.waypoints[2];
        }
        for (int i = 0; i < Interscene.instance.waypoints.Length; i++) {
            Interscene.instance.waypoints[i] = waypoints[i].position;
        }
    }

    void Update() {
        if (SceneManager.GetActiveScene().name.Equals("Level")) {
            if (Input.GetKeyDown(KeyCode.F1)) {
                SceneManager.LoadScene("FinishedLevel");
            }
        }
    }

    private Vector3 RandomPosition1() {
        float xMaxBoundary = _ScreenSizeX / _ScreenDivide * 2 - _ScreenOffset;
        float xMinBoundary = _ScreenSizeX / _ScreenDivide - _ScreenOffset;
        float yMaxBoundary = _YMax;
        float yMinBoundary = _YMin;
        Vector3 rando = new Vector3(Random.Range(xMinBoundary, xMaxBoundary), Random.Range(yMinBoundary, yMaxBoundary), 0);
        foreach (Transform hazard in Hazards.hazards) {
            SpriteRenderer texture = hazard.GetComponent<SpriteRenderer>();
            while (rando.x > texture.bounds.min.x && rando.x < texture.bounds.max.x && rando.y > texture.bounds.min.y && rando.y < texture.bounds.max.y) {
                if (rando.x > texture.bounds.center.x) {
                    rando.x++;
                } else {
                    rando.x--;
                }
                if (rando.y > texture.bounds.center.y) {
                    rando.y++;
                } else {
                    rando.y--;
                }
            }
        }
        for (int i = 0; i < waypoints.Length; i++) {
            if (waypoints[i] == null) {
                continue;
            }
            SpriteRenderer texture = waypoints[i].GetComponent<SpriteRenderer>();
            while (rando.x > texture.bounds.min.x && rando.x < texture.bounds.max.x && rando.y > texture.bounds.min.y && rando.y < texture.bounds.max.y) {
                if (rando.x > texture.bounds.center.x) {
                    rando.x++;
                } else {
                    rando.x--;
                }
                if (rando.y > texture.bounds.center.y) {
                    rando.y++;
                } else {
                    rando.y--;
                }
            }
        }
        return rando;
    }

    private Vector3 RandomPosition2() {
        float xMaxBoundary = _ScreenSizeX / _ScreenDivide * 3 - _ScreenOffset;
        float xMinBoundary = _ScreenSizeX / _ScreenDivide * 2- _ScreenOffset;
        float yMaxBoundary = _YMax;
        float yMinBoundary = _YMin;
        Vector3 rando = new Vector3(Random.Range(xMinBoundary, xMaxBoundary), Random.Range(yMinBoundary, yMaxBoundary), 0);
        foreach (Transform hazard in Hazards.hazards) {
            SpriteRenderer texture = hazard.GetComponent<SpriteRenderer>();
            while (rando.x > texture.bounds.min.x && rando.x < texture.bounds.max.x && rando.y > texture.bounds.min.y && rando.y < texture.bounds.max.y) {
                if (rando.x > texture.bounds.center.x) {
                    rando.x++;
                } else {
                    rando.x--;
                }
                if (rando.y > texture.bounds.center.y) {
                    rando.y++;
                } else {
                    rando.y--;
                }
            }
        }
        for (int i = 0; i < waypoints.Length; i++) {
            if (waypoints[i] == null) {
                continue;
            }
            SpriteRenderer texture = waypoints[i].GetComponent<SpriteRenderer>();
            while (rando.x > texture.bounds.min.x && rando.x < texture.bounds.max.x && rando.y > texture.bounds.min.y && rando.y < texture.bounds.max.y) {
                if (rando.x > texture.bounds.center.x) {
                    rando.x++;
                } else {
                    rando.x--;
                }
                if (rando.y > texture.bounds.center.y) {
                    rando.y++;
                } else {
                    rando.y--;
                }
            }
        }
        return rando;
    }

    private Vector3 RandomPosition3() {
        float xMaxBoundary = _ScreenSizeX / _ScreenDivide * 4 - _ScreenOffset;
        float xMinBoundary = _ScreenSizeX / _ScreenDivide * 3 - _ScreenOffset;
        float yMaxBoundary = _YMax;
        float yMinBoundary = _YMin;
        Vector3 rando = new Vector3(Random.Range(xMinBoundary, xMaxBoundary), Random.Range(yMinBoundary, yMaxBoundary), 0);
        foreach (Transform hazard in Hazards.hazards) {
            SpriteRenderer texture = hazard.GetComponent<SpriteRenderer>();
            while (rando.x > texture.bounds.min.x && rando.x < texture.bounds.max.x && rando.y > texture.bounds.min.y && rando.y < texture.bounds.max.y) {
                if (rando.x > texture.bounds.center.x) {
                    rando.x++;
                } else {
                    rando.x--;
                }
                if (rando.y > texture.bounds.center.y) {
                    rando.y++;
                } else {
                    rando.y--;
                }
            }
        }
        for (int i = 0; i < waypoints.Length; i++) {
            if (waypoints[i] == null) {
                continue;
            }
            SpriteRenderer texture = waypoints[i].GetComponent<SpriteRenderer>();
            while (rando.x > texture.bounds.min.x && rando.x < texture.bounds.max.x && rando.y > texture.bounds.min.y && rando.y < texture.bounds.max.y) {
                if (rando.x > texture.bounds.center.x) {
                    rando.x++;
                } else {
                    rando.x--;
                }
                if (rando.y > texture.bounds.center.y) {
                    rando.y++;
                } else {
                    rando.y--;
                }
            }
        }
        return rando;
    }
}
