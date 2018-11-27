export class Ceiling {
  private squareMeterPerLiter = 8;
  constructor() {}

  get squareMeter(): number {
    return 0;
  }
  get liter() {
    if (this.squareMeter % this.squareMeterPerLiter > 0) {
      return Math.round(this.squareMeter / this.squareMeterPerLiter + 1);
    }
    return this.squareMeter / this.squareMeterPerLiter;
  }
}

export class SquareCeiling extends Ceiling {
  constructor(private length: number, private width: number) {
    super();
  }

  get squareMeter() {
    return this.length * this.width;
  }
}

export class RoundCeiling extends Ceiling {
  constructor(private diameter: number) {
    super();
  }

  get squareMeter() {
    return this.diameter * 3.14;
  }
}

export class LshapeCeiling extends Ceiling {
  constructor(private aLength: number, private aWidth: number, private bLength: number, private bWidth: number) {
    super();
  }

  get squareMeter() {
    return (this.aLength * this.aWidth) - (this.bLength * this.bWidth);
  }
}
