import { Component, OnInit } from '@angular/core';
import { SquareCeiling, RoundCeiling, Ceiling, LshapeCeiling } from '../shared/ceiling';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  title = 'Paint Calculator';
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

  onChangeSelect(event: any) {
    this.clear();
  }

  clear() {
    this.aLenght = undefined;
    this.aWidth = undefined;
    this.bLenght = undefined;
    this.bWidth = undefined;
    this.aDiameter = undefined;
    this.submitted = false;
  }

  onSubmit() {
    this.submitted = true;
    // convert index to a number
    switch (this.index * 1) {
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
