export class ConflgValues {
  private FieldName: string;
  private FieldType: string;
  private FieldInfo: string;

  constructor(fieldName: string, fieldType: string, fieldInfo: string) {
    this.FieldName = fieldName;
    this.FieldType = fieldType;
    this.FieldInfo = fieldInfo;
  }

  fieldName(): string {
    return `${this.FieldName}`;
  }

  fieldType(): string {
    return `${this.FieldType}`;
  }

  fieldInfo(): string {
    return `${this.FieldInfo}`;
  }
}
