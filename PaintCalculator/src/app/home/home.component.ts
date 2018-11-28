import { Component, OnInit } from '@angular/core';
import { SquareCeiling, RoundCeiling, Ceiling, LshapeCeiling } from '../shared/ceiling';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  submitted = false;
  roomTypes = ['Square', 'Round', 'Lshape'];
  roomType = this.roomTypes[0];
  index = 0;
  aLenght: number;
  aWidth: number;
  bLenght: number;
  bWidth: number;
  aDiameter: number;
  squareMeter: number;
  liter: number;
  ceiling: Ceiling;

  constructor() { }

  ngOnInit() {
  }

  onChangeSelect() {
    this.index = this.roomTypes.indexOf(this.roomType);
    this.resetNumbers();
  }

  resetNumbers() {
    this.aLenght = null;
    this.aWidth = null;
    this.bLenght = null;
    this.bWidth = null;
    this.aDiameter = null;
    this.submitted = false;
  }

  onSubmit() {
    this.submitted = true;
    switch (this.index) {
      case 0: {
        this.ceiling = new SquareCeiling(this.aLenght, this.aWidth);
        break;
      }
      case 1: {
        this.ceiling = new RoundCeiling(this.aDiameter);
        break;
      }
      case 2: {
        this.ceiling = new LshapeCeiling(this.aLenght, this.aWidth, this.bLenght, this.bWidth);
        break;
      }
      default: {
        this.ceiling = new SquareCeiling(this.aLenght, this.aWidth);
        break;
      }
    }

    this.squareMeter = this.ceiling.squareMeter;
    this.liter = this.ceiling.liter;
  }

}
