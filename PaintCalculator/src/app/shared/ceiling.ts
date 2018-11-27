export class Ceiling {
  private squareMeterPerLiter = 8;
  constructor() {}

  get squareMeter(): number {
    return 0;
  }
  get liter() {
    return Math.ceil(this.squareMeter / this.squareMeterPerLiter);
  }
}

export class SquareCeiling extends Ceiling {
  constructor(private length: number, private width: number) {
    super();
  }

  get squareMeter() {
    return Math.round(this.length * this.width * 100) / 100;
  }
}

export class RoundCeiling extends Ceiling {
  constructor(private diameter: number) {
    super();
  }

  get squareMeter() {
    return Math.round(this.diameter * 3.14 * 100) / 100;
  }
}

export class LshapeCeiling extends Ceiling {
  constructor(
    private aLength: number,
    private aWidth: number,
    private bLength: number,
    private bWidth: number
  ) {
    super();
  }

  get squareMeter() {
    return (
      Math.round(
        (this.aLength * this.aWidth - this.bLength * this.bWidth) * 100
      ) / 100
    );
  }
}
