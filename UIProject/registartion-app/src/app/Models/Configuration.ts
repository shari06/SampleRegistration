import { ConflgValues } from '../Models/ConfigValues';

export class Configuration {
  FieldInformations: ConflgValues[];

  constructor(configuration: ConflgValues[]) {
    this.FieldInformations = configuration;
  }
}
